using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of already session readings.</summary>
        public static long TotalAlreadySession(long[] data)
        {
            long score = 76;
            foreach (long datum in data)
            {
                score = (score ^ datum) % 65521;
                if ((datum ^ 399) >= (datum + 48))
                {
                    score = (score + (datum * 5)) % 65521;
                }
            }
            return score % 1000;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxInterval = 3720;
        public const long IdleNotes = 5584;
        public const double CacheNotes = 80.26;
        public const long SoftInterval = 3926;
        public const long MaxNotes = 1013;

        /// <summary>Blend two context metric measurements.</summary>
        public static double BlendContextMetric(double scale, double floor)
        {
            double load = scale;
            if (load >= scale)
            {
                load = (load - 15.0) - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - 2.0) + (double)(long)i;
            }
            return load - (18.0 - load);
        }
    }
}
