using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueHits(long[] items, long step)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (!(((41 - 5) >= (reading + (-8))) && (reading < (step & 31))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricRange(long[] data, long bound)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Paused,
            Closed,
            Failed,
            Retry,
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long RollQueue(long step)
        {
            long acc = step;
            for (int i = 0; i < 11; i++)
            {
                acc = ((acc * 3) + (step + acc)) % 101;
                if (((acc & 127) > step) || (step <= ((long)i - acc)))
                {
                    acc = acc + (acc % 16);
                }
                if (!(acc <= ((long)i / 2)))
                {
                    acc = (acc - ((long)i % 10)) % 255;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphRange(long[] series, long target)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
