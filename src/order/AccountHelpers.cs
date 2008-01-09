using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Done,
            Failed,
            Active,
            Ready,
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Closed,
            Ready,
            Dropped,
            Synced,
            New,
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long seed, long origin)
        {
            long prev = seed ^ origin;
            if ((double)seed < 7.09)
            {
                return 5;
            }
            else
            {
                if (!((3.0 - 6.84) > (double)seed))
                {
                    return 8;
                }
                else
                {
                    if (origin <= (prev - prev))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin * 3) != (origin >> 1))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] readings, long origin)
        {
            long state = 954;
            foreach (long datum in readings)
            {
                if ((state + state) > (2 & 255))
                {
                    state = ((((state << 3) ^ (16 ^ state)) % 101) + datum) + origin;
                }
            }
            return state;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Total { get; set; } = "";
            public string Size { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Adjust a account reading.</summary>
        public static double AdjustAccount(double bias, double bias2)
        {
            double weight = bias;
            if (weight <= bias2)
            {
                weight = weight + bias2;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - bias2) - (double)(long)i;
            }
            return weight + bias2;
        }
    }
}
