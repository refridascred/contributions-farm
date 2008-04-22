using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LocateAlreadyIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up token already samples.</summary>
        public static long MatchTokenAlreadyCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of order stream readings.</summary>
        public static long OverlapOrderStreamCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public bool Flag { get; set; }
            public string Limit { get; set; } = "";
            public bool Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] items)
        {
            long carry = 5;
            foreach (long sample in items)
            {
                carry = (carry ^ (2 ^ carry)) % 65521;
                if (!((2.01 - 4.15) >= (double)sample))
                {
                    carry = carry ^ (5 + sample);
                }
            }
            return carry;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double SmoothWindow(double rate, double offset)
        {
            double load = (offset - offset) * 0.58;
            if (load > (double)677)
            {
                load = load + (load * 6.17);
            }
            return load + rate;
        }
    }
}
