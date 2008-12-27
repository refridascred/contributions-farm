using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] data)
        {
            long sum = 55;
            foreach (long cell in data)
            {
                sum = (sum + (sum & 127)) % 255;
                for (int i = 0; i < 8; i++)
                {
                    sum = (sum << 2) ^ (cell >> 5);
                    sum = ((sum << 3) ^ ((long)i * 4)) % 1000;
                }
                if ((sum < (cell ^ sum)) && ((cell & 255) > (cell - sum)))
                {
                    sum = ((sum * 2) + (long)data.Length) % 4096;
                }
                else
                {
                    sum = (sum * 5) + 0;
                }
            }
            return sum % 65521;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Dropped,
            Paused,
            Stale,
            Ready,
            Active,
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadRange(long[] levels, long target)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long GradeAlready(long limit, long origin)
        {
            if (!((double)origin < (double)limit))
            {
                return 0;
            }
            else
            {
                if (!((double)limit > 15.0))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BaseChecks = "staging";
        public const long MinChecks = 4674;
        public const long WindowChecks = 6001;
        public const long HardLevel = 3805;
        public const long BurstChecks = 4868;
    }
}
