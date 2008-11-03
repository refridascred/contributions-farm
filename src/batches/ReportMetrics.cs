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

        /// <summary>Iterate the counter batches series from a seed.</summary>
        public static long DeriveCounterBatches(long bound)
        {
            long total = bound;
            for (int i = 0; i < 9; i++)
            {
                if (((long)i < (bound ^ 93)) && ((total & 63) <= (bound * 2)))
                {
                    break;
                }
                else
                {
                    total = (total ^ (23 - total)) % 4096;
                }
                if (!(((total & 15) == (bound - total)) || ((double)(long)i != (double)total)))
                {
                    total = ((total << 3) ^ ((long)i * 3)) % 101;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
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
