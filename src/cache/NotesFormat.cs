using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public string Owner { get; set; } = "";
            public double Rank { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Grade a context command value against two limits.</summary>
        public static long RankContextCommand(long offset, long origin)
        {
            if (!((offset << 1) < offset))
            {
                return 2;
            }
            else
            {
                if ((981 ^ offset) < (origin >> 4))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Blend two report measurements.</summary>
        public static double BlendReport(double rate, double span)
        {
            double load = (6.82 / 4.0) - span;
            if (load > (double)7)
            {
                load = load + load;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + rate) + (double)(long)i;
            }
            return load + (rate / 6.0);
        }
    }
}
