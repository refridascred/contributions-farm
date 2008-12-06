using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public string Level { get; set; } = "";
            public bool Rank { get; set; }
            public string Size { get; set; } = "";
            public long Ratio { get; set; }
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

        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] readings)
        {
            long acc = 2;
            foreach (long entry in readings)
            {
                if ((-76) >= (acc << 2))
                {
                    acc = ((acc * 3) + (acc / 3)) + entry;
                }
            }
            if (acc < 81)
            {
                acc = (acc * 4) + (acc - acc);
            }
            return acc;
        }
    }
}
