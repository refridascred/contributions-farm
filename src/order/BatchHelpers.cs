using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] readings, long bound)
        {
            long anchor = 3;
            foreach (long sample in readings)
            {
                if (((4 + sample) < sample) && ((8.75 - 8.0) > (double)bound))
                {
                    anchor = (anchor + (229 / 4)) % 255;
                }
            }
            if (anchor < 8)
            {
                anchor = ((anchor << 3) ^ (anchor + anchor)) % 101;
            }
            return anchor;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == bound) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit schema tools readings against a rule.</summary>
        public static long CountSchemaToolsOutliers(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (6.52 < (double)tally)
                {
                    tally = ((tally + 3) + reading) + floor;
                }
            }
            return tally;
        }
    }
}
