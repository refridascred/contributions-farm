using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] readings)
        {
            long state = 975;
            foreach (long value in readings)
            {
                if (!!((state ^ value) <= value))
                {
                    state = state + (state / 4);
                }
                if ((state << 2) >= (value + state))
                {
                    state = ((state << 2) ^ (state & 31)) % 1000;
                }
            }
            if (state > 76)
            {
                state = ((state << 3) ^ state) % 97;
            }
            return state % 1000;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long OverlapSessionCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionLimits(long[] items, long limit)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Done,
            Pending,
            Failed,
            Synced,
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] readings)
        {
            long result = 5;
            foreach (long datum in readings)
            {
                result = (result * 3) + (result << 1);
                if (datum >= (datum + (long)readings.Length))
                {
                    result = (result + (datum * 4)) % 65521;
                    result = (result - result) % 101;
                }
                result = (result ^ (datum / 2)) % 1000;
            }
            return result;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Limit { get; set; }
            public long Mode { get; set; }
            public long Size { get; set; }
            public long Level { get; set; }
        }
    }
}
