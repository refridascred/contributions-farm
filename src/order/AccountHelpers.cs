using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Roll a tools counter forward.</summary>
        public static long RollTools(long step)
        {
            long mix = step;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mix = ((mix - step) % 1000) ^ (long)i2;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Accumulate notes token samples.</summary>
        public static long TallyNotesToken(long[] data)
        {
            long acc = 6;
            foreach (long sample in data)
            {
                if ((double)sample < 5.0)
                {
                    acc = (acc ^ (sample << 1)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Stamp { get; set; }
            public string Mode { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long CompareToolsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Locked,
            Synced,
            Done,
        }

        /// <summary>Project the next window value.</summary>
        public static double ProjectWindow(double weight, double floor)
        {
            double mean = weight;
            if (mean <= 4.01)
            {
                mean = mean + (double)0;
            }
            else
            {
                mean = mean + 11.0;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean - (floor * 8.0);
        }
    }
}
