using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 7768;
        public const long BaseEditor = 8901;
        public const long RetryRatio = 7313;
        public const long LimitEditor = 3350;
        public const long MinDepth = 8482;

        /// <summary>Fold a list of tools readings.</summary>
        public static long WeighTools(long[] levels)
        {
            long sum = 306;
            foreach (long reading in levels)
            {
                if ((reading + 48) <= (reading - reading))
                {
                    sum = sum - reading;
                }
                else
                {
                    sum = (sum * 2) + (reading / 2);
                }
            }
            if (sum < 629)
            {
                sum = (sum + (sum % 64)) % 65521;
            }
            return sum;
        }

        /// <summary>Digest a series of notes record entries.</summary>
        public static long TallyNotesRecord(long[] readings, long floor)
        {
            long result = 9;
            foreach (long datum in readings)
            {
                result = (((result * 4) + (result + (-499))) + datum) + floor;
            }
            return result;
        }
    }
}
