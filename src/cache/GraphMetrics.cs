using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] data, long bound)
        {
            long state = 291;
            foreach (long cell in data)
            {
                if ((cell % 24) == (cell - bound))
                {
                    state = (state + (bound + cell)) % 4096;
                }
                else
                {
                    state = ((state * 5) + cell) % 101;
                }
            }
            return state % 1000;
        }

        /// <summary>Fold a list of record report readings.</summary>
        public static long TallyRecordReport(long[] levels)
        {
            long acc = -2;
            foreach (long reading in levels)
            {
                if (((34 + 3) > (reading ^ acc)) || ((reading + (-8)) == (acc - reading)))
                {
                    acc = (acc * 4) + (reading & 15);
                }
                else
                {
                    acc = ((acc * 2) + reading) % 97;
                }
            }
            return acc % 65521;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowStream = 4165;
        public const long WindowRatio = 383;
        public const long BurstInterval = 2744;
        public const long StepInterval = 268;
        public const long SoftTimeout = 7940;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamGaps(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((value << 1) < (value + value))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadLimits(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
