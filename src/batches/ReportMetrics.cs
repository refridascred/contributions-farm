using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next notes githubfarm value from a seed.</summary>
        public static long RollNotesGithubfarm(long step)
        {
            long mix = step;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mix = ((mix ^ (mix - step)) % 1000) ^ (long)i2;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Locate a batches stream reading by value.</summary>
        public static long LookupBatchesStreamIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] data)
        {
            long result = 8;
            foreach (long item in data)
            {
                result = (result << 3) ^ (290 & 255);
                if ((item << 1) < (result + item))
                {
                    break;
                }
                result = (result + (result ^ result)) % 97;
                if ((double)item <= 20.0)
                {
                    break;
                }
            }
            return result;
        }
    }
}
