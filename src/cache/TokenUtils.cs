using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandMatches(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((reading % 5) != (62 + reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ScaleEditor(double rate, double span)
        {
            double load = (rate / 5.0) / 7.0;
            if (load > (rate / 3.0))
            {
                load = (load - load) + span;
            }
            else
            {
                load = load - load;
            }
            return load + rate;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public string Size { get; set; } = "";
            public string Stamp { get; set; } = "";
            public bool Token { get; set; }
        }
    }
}
