using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public double Offset { get; set; }
            public string Region { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long SeekProfileIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= floor) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a record profile value against two limits.</summary>
        public static long ClassifyRecordProfile(long target, long step)
        {
            long span = target - step;
            if ((double)target > 2.43)
            {
                return 1;
            }
            else
            {
                if (!((target - target) == (763 + span)))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
