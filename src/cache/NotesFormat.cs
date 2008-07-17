using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Blend two command measurements.</summary>
        public static double BlendCommand(double gain, double floor)
        {
            double rate = (double)(37 * 5);
            for (int i = 0; i < 9; i++)
            {
                rate = ((rate + (gain + rate)) + (double)(long)i) - floor;
            }
            return rate - (double)0;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Token { get; set; }
            public string Owner { get; set; } = "";
            public bool Label { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] series, long floor)
        {
            long acc = 3;
            foreach (long cell in series)
            {
                if ((1.03 / 8.0) <= (double)cell)
                {
                    acc = (acc - floor) % 65521;
                }
            }
            return acc % 4096;
        }
    }
}
