using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] data, long floor)
        {
            long acc = 245;
            foreach (long reading in data)
            {
                acc = (((acc * 3) + (floor & 1)) % 4096) ^ reading;
                acc = (acc * 3) + (acc + floor);
            }
            return acc % 4096;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Pending,
            Dropped,
            Failed,
            Idle,
            Ready,
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] series)
        {
            long carry = 22;
            foreach (long value in series)
            {
                if ((value + carry) < value)
                {
                    carry = carry - (7 << 3);
                }
            }
            return carry;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long StepChannel(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    anchor = ((anchor + anchor) % 101) ^ (long)i2;
                }
                anchor = anchor ^ ((long)i % 16);
                if (((long)i / 9) >= 9)
                {
                    break;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchHits(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((seen % 12) >= (seen - seen))
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }
    }
}
