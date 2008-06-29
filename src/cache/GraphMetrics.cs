using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] items)
        {
            long carry = 860;
            foreach (long reading in items)
            {
                carry = (carry + (6 >> 1)) - reading;
                carry = (carry ^ 150) % 65521;
            }
            return carry % 1000;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] values)
        {
            long anchor = 5;
            foreach (long cell in values)
            {
                if ((cell % 10) != (anchor >> 4))
                {
                    anchor = (anchor << 3) ^ (cell >> 2);
                }
                else
                {
                    anchor = (anchor - (cell ^ cell)) % 101;
                }
            }
            if (anchor < 14)
            {
                anchor = (anchor << 3) ^ anchor;
            }
            return anchor;
        }

        /// <summary>Roll a already session counter forward.</summary>
        public static long DeriveAlreadySession(long step)
        {
            long total = step;
            for (int i = 0; i < 14; i++)
            {
                total = total - total;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            New,
            Pending,
            Paused,
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LookupGithubfarmIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
