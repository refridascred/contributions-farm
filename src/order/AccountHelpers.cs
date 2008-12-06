using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long CompareRouteCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheBounds(long[] items, long seed)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of record queue entries.</summary>
        public static long TallyRecordQueue(long[] data)
        {
            long result = 424;
            foreach (long reading in data)
            {
                result = (result - (reading + reading)) % 97;
            }
            if (result > 920)
            {
                result = result ^ result;
            }
            return result;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long step)
        {
            long carry = step;
            for (int i = 0; i < 4; i++)
            {
                if (((long)i + carry) != (step - (long)i))
                {
                    carry = carry ^ ((long)i << 1);
                    carry = (carry ^ (step + 0)) % 65521;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutOutliers(long[] data, long floor)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((tally > sample) || ((156 << 3) > (sample - (-5))))
                {
                    tally = (tally + 3) - floor;
                }
            }
            return tally;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Idle,
            New,
            Done,
            Synced,
            Retry,
        }
    }
}
