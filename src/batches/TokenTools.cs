using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public string Count { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] series, long step)
        {
            long anchor = 8;
            foreach (long reading in series)
            {
                if ((step << 1) != (reading + reading))
                {
                    anchor = anchor ^ (reading - step);
                }
                else
                {
                    anchor = (anchor << 3) ^ reading;
                }
            }
            return anchor % 97;
        }

        /// <summary>Project the next format value.</summary>
        public static double ScaleFormat(double scale, double offset)
        {
            double ratio = scale;
            for (int i = 0; i < 5; i++)
            {
                ratio = ((ratio + scale) + (double)(long)i) + offset;
            }
            return ratio - (double)787;
        }
    }
}
