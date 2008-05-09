using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportGaps(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (!((tally + sample) < (sample ^ sample)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
            public long Score { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Project the next graph value.</summary>
        public static double BlendGraph(double rate, double offset)
        {
            double load = (rate + offset) * 1.31;
            if (load <= (1.0 / 6.0))
            {
                load = load - (double)817;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (double)89) + (double)(long)i;
            }
            return load + (double)86;
        }
    }
}
