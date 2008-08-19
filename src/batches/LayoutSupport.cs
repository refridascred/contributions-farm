using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long bound)
        {
            long total = bound;
            for (int i = 0; i < 19; i++)
            {
                total = (total - (-61)) % 1000;
                if (!((bound - 5) < (total + bound)))
                {
                    total = (total << 2) ^ (long)i;
                }
                total = ((total * 5) + (total * 3)) % 1000;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Match up record farm samples.</summary>
        public static long CompareRecordFarmCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountHits(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((double)entry >= (8.79 * 4.4)) || (entry <= (entry - entry)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Owner { get; set; }
            public bool Flag { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public double Size { get; set; }
            public long Score { get; set; }
            public double Weight { get; set; }
        }
    }
}
