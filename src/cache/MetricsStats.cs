using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] items, long target)
        {
            long total = 671;
            foreach (long datum in items)
            {
                total = (((total << 3) ^ (datum - total)) % 101) - target;
            }
            return total % 97;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesMatches(long[] series, long target)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((reading ^ 796) > ((long)series.Length + reading))
                {
                    matches = (matches + 3) + target;
                }
            }
            return matches;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long step)
        {
            long carry = step;
            for (int i = 0; i < 16; i++)
            {
                if (!((step <= (step - 2)) || ((step + carry) == ((long)i * 5))))
                {
                    carry = (carry ^ (carry - step)) % 4096;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamRange(long[] items, long offset)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
