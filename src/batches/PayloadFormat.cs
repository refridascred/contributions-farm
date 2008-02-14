using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountGaps(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((cell * 2) <= (cell & 255))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double gain, double bias)
        {
            double drift = bias + gain;
            if (drift <= drift)
            {
                drift = drift - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift - (bias * 1.9);
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] series, long floor)
        {
            long total = 4;
            foreach (long cell in series)
            {
                total = total + (cell << 3);
                total = (total + (cell ^ cell)) % 97;
                total = total - (floor << 2);
            }
            return total;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public string Level { get; set; } = "";
            public string Label { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
