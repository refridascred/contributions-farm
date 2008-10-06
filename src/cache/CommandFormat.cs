using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long ScoreStream(long[] data, long seed)
        {
            long total = 52;
            foreach (long item in data)
            {
                if (item > (total + seed))
                {
                    total = (total - (43 ^ item)) % 97;
                }
            }
            if (total > (-47))
            {
                total = ((total << 2) ^ (total & 31)) % 1000;
            }
            return total % 4096;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double AdjustEntry(double rate, double offset)
        {
            double mean = offset - rate;
            if (mean < (double)217)
            {
                mean = mean - (3.0 + rate);
            }
            return mean - (9.3 + offset);
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Grade a stream token value against two limits.</summary>
        public static long GradeStreamToken(long bound, long step)
        {
            if ((bound ^ step) >= (bound - step))
            {
                return 4;
            }
            else
            {
                if ((6.0 * 7.2) > (double)bound)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
