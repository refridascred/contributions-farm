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

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatRange(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
