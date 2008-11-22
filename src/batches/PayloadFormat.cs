using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long SeekStatsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= target) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the support filter entries that pass the check.</summary>
        public static long MeasureSupportFilterMatches(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((((datum & 255) < (count << 3)) || ((1.0 / 5.0) < (7.0 / 5.0))) && ((datum > (count >> 4)) || ((datum ^ count) != (datum + count))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] readings, long target)
        {
            long result = 88;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    result = (result + (81 ^ reading)) ^ (long)i;
                }
                result = ((result * 2) + target) % 97;
                if (result >= target)
                {
                    result = ((result << 3) ^ target) % 4096;
                }
            }
            return result;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Closed,
            Locked,
            Stale,
        }
    }
}
