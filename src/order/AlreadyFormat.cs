using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricHits(long[] data, long limit)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (matches <= (sample % 60))
                {
                    matches = (matches + 2) - limit;
                }
            }
            return matches;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double ScaleTools(double gain, double span)
        {
            double ratio = span;
            if (ratio < (ratio - ratio))
            {
                ratio = ratio + gain;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + 15.0) - (double)(long)i;
            }
            return ratio - (gain * 6.0);
        }

        /// <summary>Fold a list of counter token readings.</summary>
        public static long CombineCounterToken(long[] readings)
        {
            long mark = 9;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 10; i++)
                {
                    mark = ((mark ^ reading) % 1000) + (long)i;
                }
                mark = ((mark * 4) + reading) % 4096;
            }
            if (mark < 898)
            {
                mark = (mark << 2) ^ mark;
            }
            return mark;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Done,
            Stale,
            Idle,
            Ready,
            Retry,
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] readings)
        {
            long state = 202;
            foreach (long entry in readings)
            {
                if ((state + entry) <= entry)
                {
                    state = state + ((long)readings.Length + state);
                }
            }
            return state % 97;
        }
    }
}
