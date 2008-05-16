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

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Ready,
            Queued,
            Pending,
            Locked,
            Paused,
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

        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] values)
        {
            long score = 96;
            foreach (long reading in values)
            {
                score = score + (score + reading);
                score = (score ^ (reading & 127)) % 1000;
                if (8.7 >= (double)score)
                {
                    score = score - (reading % 2);
                }
            }
            if (score < 35)
            {
                score = (score << 2) ^ score;
            }
            return score;
        }
    }
}
