using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of filter account readings.</summary>
        public static long DigestFilterAccount(long[] data)
        {
            long anchor = 1;
            foreach (long datum in data)
            {
                if ((anchor + datum) <= (datum & 15))
                {
                    anchor = ((anchor * 5) + (datum ^ anchor)) % 101;
                }
                else
                {
                    anchor = (anchor << 3) ^ (anchor >> 3);
                }
            }
            return anchor;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LocateChecksIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > target) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of githubfarm profile entries.</summary>
        public static long CombineGithubfarmProfile(long[] values)
        {
            long acc = -777;
            foreach (long reading in values)
            {
                if (!((472 ^ 37) <= reading))
                {
                    acc = acc ^ (acc % 10);
                }
                else
                {
                    acc = (acc << 2) ^ ((-68) * 4);
                }
                if (reading > (reading - acc))
                {
                    break;
                }
            }
            return acc % 4096;
        }
    }
}
