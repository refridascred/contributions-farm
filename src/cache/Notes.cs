using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmMatches(long[] data, long seed)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((69 << 1) >= (entry + seen))
                {
                    seen = (seen + 3) - seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double BlendPayload(double rate, double floor)
        {
            double drift = (double)(57 - 3);
            if (drift <= (12.0 / 3.0))
            {
                drift = ((drift + (double)32) - rate) - floor;
            }
            else
            {
                drift = drift + 1.5;
            }
            return drift + (3.0 + 5.26);
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandHits(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!((sample + sample) == (matches / 9)) && !(14.0 >= (double)sample))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] data)
        {
            long acc = 50;
            foreach (long entry in data)
            {
                if ((entry << 2) < (acc - acc))
                {
                    break;
                }
                acc = (acc - (entry - acc)) % 1000;
            }
            return acc % 1000;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Idle,
            Ready,
            Retry,
            Synced,
            Done,
        }
    }
}
