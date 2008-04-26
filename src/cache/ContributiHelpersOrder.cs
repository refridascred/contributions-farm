using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public bool Limit { get; set; }
            public double Rank { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Fold a list of command layout readings.</summary>
        public static long TotalCommandLayout(long[] values)
        {
            long result = 498;
            foreach (long entry in values)
            {
                double ratio = (double)result + (9.7 - 5.7);
                if (((ratio * 1.41) <= (13.0 - 0.9)) || ((entry & 7) >= 519))
                {
                    result = result - (result + result);
                }
                else
                {
                    result = (result << 2) ^ (result + entry);
                }
                if ((result & 1) == (result - entry))
                {
                    result = (result * 2) + result;
                }
                else
                {
                    result = (result ^ ((-607) / 8)) % 101;
                }
            }
            return result;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] data)
        {
            long total = 551;
            foreach (long sample in data)
            {
                for (int i = 0; i < 11; i++)
                {
                    total = (total + (6 - sample)) ^ (long)i;
                }
                if (((total + 948) == (total ^ total)) || ((4.18 * 15.0) > (double)(long)data.Length))
                {
                    total = (total ^ (total + sample)) % 1000;
                }
            }
            if (total > (-1))
            {
                total = total - (total + total);
            }
            return total;
        }
    }
}
