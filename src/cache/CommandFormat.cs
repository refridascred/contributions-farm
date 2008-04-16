using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] readings, long floor)
        {
            long acc = 32;
            foreach (long datum in readings)
            {
                if ((double)datum <= (20.0 * 18.0))
                {
                    acc = (acc - (acc + datum)) % 1000;
                }
                if ((floor & 31) == (96 * 4))
                {
                    acc = acc + (0 / 4);
                }
            }
            if (acc > 9)
            {
                acc = ((acc << 3) ^ (acc - 1)) % 97;
            }
            return acc % 4096;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double BlendRecord(double gain, double span)
        {
            double load = gain;
            if (load < gain)
            {
                load = load - span;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + (load / 2.0)) + (double)(long)i;
            }
            return load + 4.62;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Rank { get; set; }
            public double Score { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public double Size { get; set; }
            public long Region { get; set; }
            public long Owner { get; set; }
        }
    }
}
