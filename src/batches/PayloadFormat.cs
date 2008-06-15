using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheGaps(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (datum < (matches + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the command cluster series from a seed.</summary>
        public static long RollCommandCluster(long floor)
        {
            long state = floor;
            for (int i = 0; i < 7; i++)
            {
                long edge = floor;
                long bound = (edge >> 1) * 2;
                if (!((state << 3) <= (bound + (long)i)))
                {
                    bound = bound + (state + floor);
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Check that every payload queue entry stays within the limit.</summary>
        public static bool GuardPayloadQueueRange(long[] readings, long floor)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
