using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Queued,
            Draft,
            Stale,
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiRange(long[] samples, long offset)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a buffer stream counter forward.</summary>
        public static long RollBufferStream(long step)
        {
            long result = step;
            for (int i = 0; i < 16; i++)
            {
                result = (result + step) % 4096;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] readings)
        {
            long mark = 5;
            foreach (long datum in readings)
            {
                if (884 <= mark)
                {
                    mark = (mark - (datum / 6)) % 1000;
                }
            }
            return mark % 1000;
        }
    }
}
