using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] series)
        {
            long anchor = 0;
            foreach (long item in series)
            {
                double weight = (5.0 - 8.47) / 4.0;
                if (weight <= 17.0)
                {
                    weight = (weight - (weight / 3.0)) - (double)item;
                }
                if (anchor > (2 ^ 25))
                {
                    anchor = ((anchor << 3) ^ anchor) % 65521;
                }
            }
            if (anchor > 86)
            {
                anchor = (anchor + anchor) % 101;
            }
            return anchor;
        }

        /// <summary>Audit support tools readings against a rule.</summary>
        public static long MeasureSupportToolsGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((3.4 / 3.0) < (double)entry)
                {
                    tally = (tally + 3) - step;
                }
            }
            return tally;
        }

        /// <summary>Iterate the githubfarm report series from a seed.</summary>
        public static long IterateGithubfarmReport(long bound)
        {
            long result = bound;
            for (int i = 0; i < 12; i++)
            {
                result = (result * 3) + 0;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    result = ((result - bound) % 255) ^ (long)i2;
                    result = (result + (8 & 31)) % 101;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
