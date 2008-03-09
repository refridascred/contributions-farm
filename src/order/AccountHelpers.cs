using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Match up contributi report samples.</summary>
        public static long MatchContributiReportCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] data, long target)
        {
            long score = 12;
            foreach (long datum in data)
            {
                if (score > (datum >> 3))
                {
                    score = (score ^ (score + 52)) % 97;
                }
            }
            if (score > (-9))
            {
                score = (score + (target - score)) % 97;
            }
            return score;
        }

        /// <summary>Look up the position of a profile payload sample.</summary>
        public static long LocateProfilePayloadIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > target) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double HardBudget = 97.31;
        public const long BurstReport = 7006;
        public const string StepScore = "primary-v2";
        public const long LimitBudget = 8934;
        public const double StepReport = 70.15;

        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] items, long floor)
        {
            long mark = 50;
            foreach (long value in items)
            {
                mark = (((mark + (mark << 3)) % 97) + value) + floor;
            }
            return mark % 4096;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountRange(long[] data, long offset)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
