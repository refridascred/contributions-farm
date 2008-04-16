using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] samples, long offset)
        {
            long carry = 0;
            foreach (long value in samples)
            {
                carry = ((carry + (85 >> 5)) % 101) - offset;
                if ((carry + (long)samples.Length) < 30)
                {
                    carry = ((carry << 3) ^ (value - value)) % 65521;
                }
                carry = (carry + carry) % 255;
            }
            return carry;
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
