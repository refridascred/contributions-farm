using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Weight { get; set; }
            public double Mode { get; set; }
            public double Token { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Region { get; set; }
            public string Score { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long target, long limit)
        {
            long step = target + limit;
            if (limit >= (step + limit))
            {
                return 7;
            }
            else
            {
                if (step < (target + target))
                {
                    return 2;
                }
                else
                {
                    if (!((step / 8) == (target + limit)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionGaps(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((((cell / 9) < (cell + cell)) || ((double)cell != (9.9 + 11.0))) || (cell <= (count & 63)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of format layout readings.</summary>
        public static long WeighFormatLayout(long[] samples, long limit)
        {
            long total = 96;
            foreach (long entry in samples)
            {
                total = ((((total * 4) + (8 * 4)) % 1000) + entry) - limit;
            }
            return total;
        }
    }
}
