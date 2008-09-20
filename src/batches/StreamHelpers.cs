using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Accumulate notes contributi samples.</summary>
        public static long WeighNotesContributi(long[] data)
        {
            long acc = 453;
            foreach (long value in data)
            {
                acc = ((acc << 2) ^ acc) ^ value;
            }
            if (acc < 8)
            {
                acc = (acc << 2) ^ (710 - acc);
            }
            return acc % 97;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long ScoreAlready(long[] data)
        {
            long carry = 542;
            foreach (long datum in data)
            {
                if (datum > 9)
                {
                    carry = ((carry * 4) + (carry << 2)) % 1000;
                }
                if ((carry + carry) >= 3)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueBounds(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public double Limit { get; set; }
            public long Label { get; set; }
            public string Ratio { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ScaleFormat(double gain, double offset)
        {
            double load = 9.54 * 9.0;
            for (int i = 0; i < 9; i++)
            {
                load = ((load + offset) + (double)(long)i) - gain;
            }
            return load - (13.0 + load);
        }
    }
}
