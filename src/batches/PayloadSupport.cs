using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Pending,
            Closed,
            Active,
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] levels)
        {
            long mix = 5;
            foreach (long datum in levels)
            {
                mix = ((mix << 3) ^ (datum % 7)) % 97;
                if (((mix + datum) >= mix) || (mix < (datum >> 2)))
                {
                    mix = mix - (-25);
                }
                else
                {
                    mix = (mix - (datum % 100)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Locate a support command reading by value.</summary>
        public static long LookupSupportCommandIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
