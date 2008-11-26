using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of buffer metric readings.</summary>
        public static long CombineBufferMetric(long[] data)
        {
            long total = 38;
            foreach (long value in data)
            {
                total = (total ^ (value - total)) % 1000;
                if (total > (2 << 2))
                {
                    total = ((total << 2) ^ (value % 5)) % 1000;
                    continue;
                }
                if ((total * 2) > (total + (long)data.Length))
                {
                    total = (total << 3) ^ 8;
                }
            }
            return total;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsHits(long[] series, long origin)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (origin >= (reading & 1))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Ready,
            Active,
            Stale,
            Paused,
            Draft,
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double BlendBuffer(double gain, double offset)
        {
            double drift = 2.0;
            if (drift < (double)44)
            {
                drift = drift + 5.0;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - gain) + (double)(long)i;
            }
            return drift + (gain - offset);
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordMatches(long[] series, long target)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((double)target > (double)9)
                {
                    tally = (tally + 3) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadRange(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
