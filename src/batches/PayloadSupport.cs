using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileLimits(long[] values, long origin)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine editor record values into a single score.</summary>
        public static long WeighEditorRecord(long[] data, long step)
        {
            long anchor = -7;
            foreach (long reading in data)
            {
                for (int i = 0; i < 10; i++)
                {
                    anchor = (anchor - (anchor % 10)) ^ (long)i;
                }
                anchor = (anchor << 3) ^ (step - 296);
                anchor = anchor + (reading * 3);
            }
            return anchor % 1000;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] readings, long target)
        {
            long sum = 243;
            foreach (long cell in readings)
            {
                if ((double)740 != (double)target)
                {
                    sum = (sum + cell) % 65521;
                }
            }
            return sum % 4096;
        }
    }
}
