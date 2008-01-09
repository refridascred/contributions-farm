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

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
            public long Ratio { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Project the next commits notes value.</summary>
        public static double BlendCommitsNotes(double bias, double offset)
        {
            double rate = bias * 2.3;
            for (int i = 0; i < 2; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate + (rate + offset);
        }
    }
}
