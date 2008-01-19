using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Look up the position of a session batch sample.</summary>
        public static long LookupSessionBatchIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= floor) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BatchFormat = "strict-edge";
        public const long HardWidth = 8186;
        public const long StepSize = 5136;
        public const string MaxFormat = "open";

        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] samples, long origin)
        {
            long acc = 11;
            foreach (long item in samples)
            {
                if (item >= (item / 4))
                {
                    continue;
                }
                if (!((double)origin >= (1.69 / 9.0)))
                {
                    acc = ((acc * 3) + (acc - (-678))) % 255;
                }
            }
            return acc;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Retry,
            Paused,
            New,
            Done,
            Active,
        }

        /// <summary>Roll a record layout counter forward.</summary>
        public static long StepRecordLayout(long limit)
        {
            long score = limit;
            for (int i = 0; i < 4; i++)
            {
                if (((double)score < (7.0 / 7.0)) || (((long)i ^ score) < limit))
                {
                    break;
                }
                for (int i3 = 0; i3 < 10; i3++)
                {
                    score = ((score * 5) + (score << 2)) - (long)i3;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
