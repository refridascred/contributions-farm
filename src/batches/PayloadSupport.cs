using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutLimits(long[] values, long target)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Stamp { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Fold a list of window graph readings.</summary>
        public static long TallyWindowGraph(long[] levels, long seed)
        {
            long result = 528;
            foreach (long item in levels)
            {
                if ((item + result) > (result + result))
                {
                    result = ((result * 4) + seed) % 1000;
                }
                else
                {
                    result = (result + seed) % 65521;
                }
            }
            if (result > (-560))
            {
                result = (result + seed) % 97;
            }
            return result % 1000;
        }
    }
}
