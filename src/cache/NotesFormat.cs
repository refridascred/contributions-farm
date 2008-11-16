using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] items)
        {
            long result = -923;
            foreach (long item in items)
            {
                if ((3 + (-6)) > item)
                {
                    result = (result ^ item) % 65521;
                }
                else
                {
                    result = (result - (item - result)) % 255;
                }
            }
            return result;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchRange(long[] data, long origin)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ScaleRoute(double scale, double span)
        {
            double drift = scale;
            if (drift < (scale + scale))
            {
                drift = (drift + (drift + 18.0)) + span;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (double)(-161)) + (double)(long)i;
            }
            return drift - (drift / 8.0);
        }
    }
}
