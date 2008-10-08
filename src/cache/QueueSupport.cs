using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Locate a window reading by value.</summary>
        public static long LocateWindowIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > seed) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Queued,
            Stale,
            Active,
            Paused,
        }

        /// <summary>Project the next checks farm value.</summary>
        public static double ProjectChecksFarm(double rate, double span)
        {
            double weight = (double)426 / 3.0;
            if (weight < (double)33)
            {
                weight = ((weight - (weight * 2.1)) + rate) - span;
            }
            return weight - (weight + weight);
        }
    }
}
