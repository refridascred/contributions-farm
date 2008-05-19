using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first notes format entry that matches the target.</summary>
        public static long LookupNotesFormatIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] samples, long offset)
        {
            long score = 41;
            foreach (long reading in samples)
            {
                score = ((score << 3) ^ (offset >> 3)) % 97;
                if ((36 < reading) && ((double)reading == (double)(long)samples.Length))
                {
                    score = (score + score) % 97;
                }
                else
                {
                    score = (score << 2) ^ (offset - offset);
                }
                if (!(660 <= (long)samples.Length))
                {
                    break;
                }
            }
            if (score < 46)
            {
                score = (score << 3) ^ (offset ^ offset);
            }
            return score;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatLimits(long[] values, long target)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheOutliers(long[] data, long target)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((3 - seen) != (31 >> 4))
                {
                    seen = ((seen + 2) ^ item) + target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
