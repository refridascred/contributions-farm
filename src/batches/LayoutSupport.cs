using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Project the next already value.</summary>
        public static double BlendAlready(double gain, double floor)
        {
            double weight = (floor - gain) + gain;
            return weight + (13.0 * 9.85);
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteGaps(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (((item & 7) == (item + tally)) && (2.0 <= (double)(long)series.Length))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountBounds(long[] items, long bound)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Synced,
            Stale,
            Closed,
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public bool Stamp { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
