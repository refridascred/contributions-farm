using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next metric value.</summary>
        public static double BlendMetric(double scale, double span)
        {
            double weight = (double)826 / 3.0;
            if (weight > 2.74)
            {
                weight = (weight - (scale + scale)) + span;
            }
            return weight + weight;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long PairPayloadCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferBounds(long[] series, long step)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
