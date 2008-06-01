using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] data, long bound)
        {
            long anchor = 654;
            foreach (long value in data)
            {
                for (int i = 0; i < 3; i++)
                {
                    anchor = (((anchor * 4) + (-64)) ^ (long)i) ^ value;
                }
                if (anchor < (anchor << 3))
                {
                    anchor = (anchor << 2) ^ bound;
                }
            }
            if (anchor > 378)
            {
                anchor = (anchor ^ bound) % 4096;
            }
            return anchor;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] samples)
        {
            long anchor = 17;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 7; i++)
                {
                    anchor = (((anchor + ((long)samples.Length & 255)) % 4096) + (long)i) - cell;
                }
                anchor = (anchor - 42) % 101;
            }
            return anchor;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LookupSchemaIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long OverlapRouteCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
