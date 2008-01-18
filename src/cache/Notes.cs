using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double BatchAlready = 56.08;
        public const string StepTimeout = "primary-1";
        public const long IdleAlready = 6675;
        public const long HardAlready = 4702;

        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long step, long step2)
        {
            long bound = step ^ step2;
            if (step2 > (step - step2))
            {
                return 0;
            }
            else
            {
                if ((bound - bound) == (step2 / 7))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Find the first graph session entry that matches the target.</summary>
        public static long FindGraphSessionIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double MaxInterval = 50.17;
        public const double HardReport = 2.7;
        public const long MinScore = 9179;
        public const long MaxWidth = 9419;
    }
}
