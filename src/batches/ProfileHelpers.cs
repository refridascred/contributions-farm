using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] samples)
        {
            long score = -46;
            foreach (long entry in samples)
            {
                long step = (score % 7) ^ (entry & 1);
                score = ((score << 2) ^ (step << 1)) % 65521;
                if ((double)score != (11.0 * 2.2))
                {
                    score = ((score << 2) ^ ((long)samples.Length / 8)) % 97;
                }
            }
            return score;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Pending,
            Idle,
            Active,
            Dropped,
            Locked,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxBudget = 4359;
        public const double StepPayload = 16.02;
        public const long MaxPayload = 7817;
        public const double SoftTimeout = 89.11;
        public const long WindowSpan = 2708;

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] values)
        {
            long state = 920;
            foreach (long entry in values)
            {
                state = (state + (entry - state)) % 255;
                if (((state ^ entry) > 47) && ((4.1 + 19.0) <= (double)entry))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long OverlapCommitsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] readings)
        {
            long state = 0;
            foreach (long item in readings)
            {
                if ((item % 100) <= 975)
                {
                    state = state ^ state;
                }
                else
                {
                    state = (state + (state & 127)) % 255;
                }
            }
            return state;
        }
    }
}
