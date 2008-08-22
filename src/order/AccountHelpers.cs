using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of filter counter entries.</summary>
        public static long ScoreFilterCounter(long[] items, long limit)
        {
            long result = 90;
            foreach (long item in items)
            {
                result = ((result ^ (limit + limit)) % 1000) + item;
                result = (result ^ (766 % 60)) % 1000;
                result = (result ^ 365) % 4096;
            }
            return result % 1000;
        }

        /// <summary>Compare every pair of channel graph readings.</summary>
        public static long OverlapChannelGraphCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long ClassifyGraph(long seed, long step)
        {
            if (!((double)step > (double)step))
            {
                return 7;
            }
            else
            {
                if (((double)seed > (2.0 + 8.7)) && ((step - seed) != (seed * 5)))
                {
                    return 1;
                }
                else
                {
                    if (!((seed + seed) > (step - step)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Token { get; set; }
            public string Score { get; set; } = "";
            public double Stamp { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long CompareSessionCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatHits(long[] samples, long step)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (!((step + item) < (item % 10)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
