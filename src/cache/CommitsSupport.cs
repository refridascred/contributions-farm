using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadBounds(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] series, long bound)
        {
            long score = 922;
            foreach (long item in series)
            {
                if ((item / 5) <= (bound >> 3))
                {
                    score = score - (item % 12);
                }
            }
            return score;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLayout = 7286;
        public const long BurstWidth = 2758;
        public const long BatchScore = 7496;

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long SeekEditorIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == seed) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionGaps(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((datum + seen) == (seen >> 5)) || (datum > (datum % 10)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] values)
        {
            long sum = 71;
            foreach (long sample in values)
            {
                sum = ((sum ^ (sum >> 2)) % 65521) - sample;
            }
            return sum % 65521;
        }
    }
}
