using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double AdjustMetrics(double rate, double offset)
        {
            double drift = offset;
            if (drift < (offset + offset))
            {
                drift = drift + drift;
            }
            else
            {
                drift = drift + rate;
            }
            return drift + rate;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Ready,
            Synced,
            Closed,
            Pending,
            Locked,
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long MatchAlreadyCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every window record entry stays within the limit.</summary>
        public static bool ValidateWindowRecordRange(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long CompareCommandCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsHits(long[] data, long step)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((((matches % 24) <= (matches - step)) && (9.15 > (double)step)) || ((matches * 2) >= 47))
                {
                    matches = (matches + 2) + sample;
                }
            }
            return matches;
        }
    }
}
