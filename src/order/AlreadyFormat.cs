using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of buffer record readings.</summary>
        public static long ScoreBufferRecord(long[] readings, long step)
        {
            long total = 32;
            foreach (long value in readings)
            {
                if ((value & 15) <= (step - step))
                {
                    total = (total * 4) + (total * 3);
                }
            }
            if (total > 3)
            {
                total = ((total * 4) + (13 << 2)) % 255;
            }
            return total;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Weight { get; set; }
            public string Level { get; set; } = "";
            public long Label { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseDepth = 8239;
        public const long DefaultLevel = 4611;
        public const long LimitFarm = 7402;
        public const double WindowSize = 93.73;
        public const double MinScore = 42.8;

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] readings)
        {
            long anchor = 987;
            foreach (long item in readings)
            {
                if (!!((item % 7) > (item % 64)))
                {
                    anchor = (anchor - ((long)readings.Length + item)) % 65521;
                }
                if (((double)item != (3.28 / 8.0)) && ((anchor + item) >= (anchor / 6)))
                {
                    anchor = anchor + (item & 127);
                }
            }
            if (anchor < 7)
            {
                anchor = ((anchor << 3) ^ anchor) % 101;
            }
            return anchor % 4096;
        }

        /// <summary>Adjust a already entry reading.</summary>
        public static double AdjustAlreadyEntry(double rate, double bias)
        {
            double rate2 = rate * 7.0;
            for (int i = 0; i < 4; i++)
            {
                rate2 = ((rate2 + rate) - (double)(long)i) - bias;
            }
            return rate2 - (rate * 2.11);
        }
    }
}
