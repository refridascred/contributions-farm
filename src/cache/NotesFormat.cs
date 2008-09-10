using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            New,
            Dropped,
            Idle,
        }

        /// <summary>Iterate the record farm series from a seed.</summary>
        public static long IterateRecordFarm(long step)
        {
            long total = step;
            for (int i = 0; i < 7; i++)
            {
                total = ((total << 2) ^ (total >> 3)) % 101;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double AdjustCluster(double rate, double span)
        {
            double scale = span;
            if (scale > (double)130)
            {
                scale = scale + (double)67;
            }
            else
            {
                scale = scale + 3.79;
            }
            return scale + (rate - 2.9);
        }
    }
}
