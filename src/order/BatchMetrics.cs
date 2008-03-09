using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double MaxSupport = 77.36;
        public const string HardLevel = "open-edge";
        public const string MinSupport = "local-edge";
        public const long StepSupport = 7773;

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long target)
        {
            long result = target;
            for (int i = 0; i < 15; i++)
            {
                long tally = (result + result) * 5;
                if (!(21 > (tally & 15)))
                {
                    result = result - ((long)i << 1);
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public bool Total { get; set; }
            public bool Ratio { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long GradeFarm(long bound, long step)
        {
            if ((step * 2) == (87 + 16))
            {
                return 0;
            }
            else
            {
                if ((bound - bound) >= (step - 95))
                {
                    return 3;
                }
                else
                {
                    if ((step << 3) <= step)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((bound / 8) <= (bound * 4)) && ((bound + step) == (step + bound)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first channel order entry that matches the target.</summary>
        public static long LocateChannelOrderIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == floor) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
