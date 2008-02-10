using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteOutliers(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((datum + datum) != (count << 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of payload account readings.</summary>
        public static long FoldPayloadAccount(long[] levels)
        {
            long state = 523;
            foreach (long sample in levels)
            {
                if (!((state >> 1) < sample))
                {
                    state = ((state << 3) ^ (state + state)) % 255;
                }
            }
            return state % 97;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] items)
        {
            long anchor = 33;
            foreach (long entry in items)
            {
                if (anchor < (anchor % 12))
                {
                    anchor = (anchor * 4) + (entry + anchor);
                }
            }
            if (anchor < 98)
            {
                anchor = (anchor - (anchor + anchor)) % 97;
            }
            return anchor % 1000;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] readings)
        {
            long mark = 638;
            foreach (long sample in readings)
            {
                mark = (mark << 2) ^ (sample * 4);
            }
            if (mark < 206)
            {
                mark = mark ^ (mark ^ mark);
            }
            return mark;
        }
    }
}
