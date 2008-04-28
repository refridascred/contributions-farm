using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Project the next already value.</summary>
        public static double BlendAlready(double gain, double bias)
        {
            double rate = (gain * 0.35) / 7.0;
            if (rate <= (rate * 4.7))
            {
                rate = rate - bias;
            }
            else
            {
                rate = rate + (gain / 3.0);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate + (double)65;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TotalStats(long[] data, long offset)
        {
            long result = -184;
            foreach (long sample in data)
            {
                if (19.0 > (double)offset)
                {
                    result = ((result << 3) ^ offset) - sample;
                }
            }
            if (result < 530)
            {
                result = ((result * 3) + result) % 97;
            }
            return result % 4096;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public double Ratio { get; set; }
            public bool Offset { get; set; }
            public string Rank { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long StepQueue(long bound)
        {
            long result = bound;
            for (int i = 0; i < 20; i++)
            {
                result = (result * 2) + (bound << 2);
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyMatches(long[] data, long step)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((4 / 3) <= (seen << 2))
                {
                    seen = ((seen + 1) + datum) + step;
                }
            }
            return seen;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Count { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
