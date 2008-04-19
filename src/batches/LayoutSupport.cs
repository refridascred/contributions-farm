using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] data)
        {
            long sum = 62;
            foreach (long entry in data)
            {
                if ((entry + entry) == (sum ^ sum))
                {
                    sum = (sum << 3) ^ (entry << 2);
                }
            }
            if (sum < 801)
            {
                sum = ((sum * 2) + (69 + sum)) % 1000;
            }
            return sum % 65521;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double DefaultStats = 80.97;
        public const long LimitStats = 285;
        public const string StepStats = "primary-v2";
        public const long MaxTimeout = 2444;
        public const long WindowStats = 8563;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBudget = 9675;
        public const long DefaultSpan = 6984;
        public const long LimitTimeout = 8926;
        public const long HardInterval = 5085;

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Draft,
            Active,
            Synced,
            Ready,
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
